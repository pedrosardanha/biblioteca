FROM alpine

RUN apk update
RUN apk add dotnet8-sdk
RUN apk add dotnet8-runtime

WORKDIR /app

COPY . .

CMD ["dotnet", "run"]