from socket import *

serverName = '127.0.0.1'
serverPort = 12000

clientSocket = socket(AF_INET, SOCK_STREAM)
clientSocket.connect((serverName, serverPort))

while True:
    sentence = input('Please enter the city name : ')

    clientSocket.send(sentence.encode())
    modifiedSentence = clientSocket.recv(2048)
    print(modifiedSentence.decode())

clientSocket.close()