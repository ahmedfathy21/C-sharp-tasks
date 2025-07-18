import serial
from time import sleep

srl = serial.Serial("/dev/ttyS0", 9600)

while True:
    # Receiving then Sending
    if srl.in_waiting > 0:
        line = srl.readline().decode('utf-8').rstrip()
        print(line)
        srl.write("Hi Ehab, greetings from Raspberry pi!\n\r".encode('utf-8'))