# Uses python3
import sys

def fibonacci_partial_sum_naive(from_, to):
    _sum = 0

    current = 0
    _next  = 1

    for i in range(to + 1):
        if i >= from_:
            _sum += current

        current, _next = _next, current + _next

    return _sum % 10

def fibonacci_partial_sum_fast(from_, to):
    _sum = 0

    current = 0
    _next  = 1

    for i in range(to + 1):
        if i >= from_:
            _sum = (current + _sum) % 10

        current, _next = _next, (current + _next) % 10

    return _sum


if __name__ == '__main__':
    input = input()
    from_, to = map(int, input.split())
    print(fibonacci_partial_sum_fast(from_, to))
