FROM node:alpine as builder 
WORKDIR /app

COPY package.json .
COPY package-lock.json .
RUN npm ci

COPY . .
RUN npm run build

FROM nginx
EXPOSE 3000
COPY --from=builder /app/dist /usr/share/nginx/html
COPY ./nginx.conf /etc/nginx/conf.d/default.conf