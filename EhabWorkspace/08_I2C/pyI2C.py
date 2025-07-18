import smbus2
import time

# I2C address of the ESP32
ESP32_I2C_ADDR = 0x08

# Initialize I2C bus (bus 1 is the default for Raspberry Pi)
bus = smbus2.SMBus(1)

def send_message(message):
    # Convert string to a list of bytes and send
    data = [ord(char) for char in message]
    try:
        bus.write_i2c_block_data(ESP32_I2C_ADDR, 0, data)
        print(f"Sent: {message}")
    except Exception as e:
        print(f"Error sending data: {e}")

def read_response():
    try:
        time.sleep(0.1)
        response = bus.read_i2c_block_data(ESP32_I2C_ADDR, 0, 19)
        response_str = ''.join(chr(byte) for byte in response).rstrip('\x00')
        print(f"Received: {response_str}")
    except Exception as e:
        print(f"Error reading data: {e}")

if __name__ == "__main__":
    try:
        while True:
            # Send a message
            send_message("Hello ESP32!")
            time.sleep(1)

            # Read the response
            read_response()
            time.sleep(2)

    except KeyboardInterrupt:
        print("Program terminated by user.")
