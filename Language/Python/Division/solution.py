#!/bin/python3

def func(a, b):
    print(f"{a // b}")
    print(f"{a / b}")    

if __name__ == '__main__':
    a = int(input())
    b = int(input())
    func(a, b)
