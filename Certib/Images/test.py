
from math import log10, sqrt
import cv2
import numpy as np
  
def PSNR(original, compressed):
    mse = np.mean((original - compressed) ** 2)
    print(f'MSE: {mse}')
    if(mse == 0):  # MSE is zero means no noise is present in the signal .
                  # Therefore PSNR have no importance.
        return 100
    max_pixel = 255.0
    psnr = 20 * log10(max_pixel / sqrt(mse))
    return psnr
  
def main():
     original = cv2.imread("template3.png")
     compressed = cv2.imread("1bf9b7b5f74c9c28c11459c0eace1cb49ebe1653349841bf5a53e93dcd7037b8.png", 1)
     value = PSNR(original, compressed)
     print(f"PSNR: {value} dB")
       
if __name__ == "__main__":
    main()