FROM golang:1.20-alpine AS builder

WORKDIR /app

COPY hello.go .

RUN go build -o hello hello.go

FROM scratch

COPY --from=builder /app/hello .

CMD ["./hello"]
