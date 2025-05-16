FROM alpine

RUN apk update
RUN apk add nodejs npm
RUN npm install -g @angular/cli

WORKDIR /app

COPY package*.json .

RUN npm install

COPY . .

CMD ["ng", "serve", "--host", "0.0.0.0"]