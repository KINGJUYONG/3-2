from socket import *

serverName = '127.0.0.1'
serverPort = 12000

clientSocket = socket(AF_INET, SOCK_DGRAM)

while True:
    message = input('Input lowercase sentence : ') # 파이썬 버전 문제로, input로 대체
    clientSocket.sendto(message.encode(), (serverName, serverPort))

    modifiedMessage, serverAddress = clientSocket.recvfrom(2048)

    print(modifiedMessage.decode())
clientSocket.close()