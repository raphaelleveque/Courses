def lcm(a, b):
    return int((a * b) / gcm(a, b))

def gcm(a, b):
    while b != 0:
        tmp = a
        a = b
        b = tmp % b
    return a
        


if __name__ == '__main__':
    a, b = map(int, input().split())
    print(lcm(a, b))

