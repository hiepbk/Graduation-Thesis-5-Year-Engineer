import tensorflow as tf
import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
file_path = 'weather.csv'
data=pd.read_csv(file_path, delimiter=',',header=11,skipinitialspace=True)
print(data)
data.head(24)
print(data.head(24))
temperature = np.array(data['Temperature'])
print(temperature)
num_periods = 24
f_horizon = 1
x_data = temperature[:(len(temperature)-(num_periods*2))]
print(x_data)
x_batches = x_data.reshape(-1, num_periods, 1)
print(x_batches)
print("x bat",x_batches.shape)

y_data = temperature[1:(len(temperature)-(num_periods*2))+f_horizon]
y_batches = y_data.reshape(-1, num_periods, 1)
print("y bat",y_batches)
print(y_batches.shape)
def test_data(series, forecast, num):
    testX = temperature[-(num + forecast):][:num].reshape(-1, num_periods, 1)
    testY = temperature[-(num):].reshape(-1, num_periods, 1)
    return testX, testY
X_test, Y_test = test_data(temperature, f_horizon, 24*2)
print(X_test.shape)
tf.reset_default_graph()
inputs = 1
rnn_size = 100
output = 1
learning_rate=0.001
dropout_keep_prob = tf.placeholder(tf.float32)

X = tf.placeholder(tf.float32, [None, num_periods, 1])
Y = tf.placeholder(tf.float32, [None, num_periods, 1])

rnn_cells=tf.contrib.rnn.BasicRNNCell(num_units=rnn_size, activation=tf.nn.relu)
rnn_output, states = tf.nn.dynamic_rnn(rnn_cells, X, dtype=tf.float32)


output=tf.reshape(rnn_output, [-1, rnn_size])
logit=tf.layers.dense(output, 1, name="softmax")

outputs=tf.reshape(logit, [-1, num_periods, 1])
print(logit)

loss = tf.reduce_sum(tf.square(outputs - Y))

accuracy = tf.reduce_mean(tf.cast(tf.equal(tf.argmax(logit, 1), tf.cast(Y, tf.int64)), tf.float32))

optimizer = tf.train.AdamOptimizer(learning_rate=learning_rate)
train_step=optimizer.minimize(loss)

init=tf.global_variables_initializer()

epochs = 100
sess = tf.Session()
init = tf.global_variables_initializer()
sess.run(init)
saver = tf.train.Saver()

for epoch in range(epochs):
    print("Training epoch ",epoch )
    train_dict = {X: x_batches, Y: y_batches, dropout_keep_prob:0.5}
    sess.run(train_step, feed_dict=train_dict)
y_pred=sess.run(outputs, feed_dict={X: X_test})
save_path = saver.save(sess, "models/weather.ckpt")

plt.title("Forecast vs Actual", fontsize=14)
plt.plot(pd.Series(np.ravel(Y_test)), "bo", markersize=10, label="Actual")
plt.plot(pd.Series(np.ravel(y_pred)), "r.", markersize=10, label="Forecast")
plt.legend(loc="upper left")
plt.xlabel("Time Periods")
plt.show()

with tf.Session() as sess:
  # Restore variables from disk.
    saver.restore(sess, "models/model.ckpt")
    predict=sess.run(outputs, feed_dict={X: X_test})
print(predict)
print(y_pred)