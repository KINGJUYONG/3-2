from socket import *
import requests
import json

apikey = "7cdf572c29ddca6ae9fb7eb65a1891cd"

serverPort = 12000
serverSocket = socket(AF_INET, SOCK_STREAM)
serverSocket.bind(('', serverPort))

serverSocket.listen(1)

print("waiting...")

connectionSocket, addr = serverSocket.accept()

#print(str(addr) + '에서 접속됨.')

while True:
    city_name = connectionSocket.recv(2048).decode()

    print(city_name,"requested")

    geoapi = f"http://api.openweathermap.org/geo/1.0/direct?q={city_name}&limit=5&appid={apikey}"

    geo = requests.get(geoapi)
    geo = json.loads(geo.text)
    geo = geo[0] # 0번째 인덱스만 가져옴

    lon = geo['lon']
    lat = geo['lat']

    weatherapi = f"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apikey}"

    weather = requests.get(weatherapi)
    weather = json.loads(weather.text)

    sentence = str("\n--------------------------------------\nWeather of " + weather['name'])

    sentence = sentence + str("\n\nweather : " + weather['weather'][0]['main'] + "(" + weather['weather'][0]['description'] + ")")
    sentence = sentence + str("\ntemp : " + str(round(weather['main']['temp'] - 273.15, 1)))
    sentence = sentence + str("\nfeels like : " + str(round(weather['main']['feels_like'] - 273.15, 1)))
    sentence = sentence + str("\nhumidity :" + str(weather['main']['humidity']) + "%")

    sentence = sentence + str("\n\nmax temp :" + str(round(weather['main']['temp_max'] - 273.15, 1)))
    sentence = sentence + str("\nmin temp :"+ str(round(weather['main']['temp_min'] - 273.15, 1)))

    sentence = sentence + str("\n\nwind speed :" + str(weather['wind']['speed']) + "\b(m/s)\n--------------------------------------\n")


    connectionSocket.send(sentence.encode())

connectionSozket.close()