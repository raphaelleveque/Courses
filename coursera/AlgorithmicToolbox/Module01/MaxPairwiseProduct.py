def maxPairwiseProduct(n, array):
    maxElem, secondMax = max(array[0], array[1]), min(array[0], array[1])
    for num in array[2:]:
        if num > maxElem:
            secondMax = maxElem
            maxElem = num
        elif num > secondMax:
            secondMax = num
    return maxElem * secondMax




if __name__ == '__main__':
    n = int(input())
    input = list(map(int, input().split()))
    print(maxPairwiseProduct(n, input))

