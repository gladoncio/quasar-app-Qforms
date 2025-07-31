# Etapa 1: Construcción
FROM node:18-alpine AS builder

WORKDIR /app
COPY . .
RUN npm install
RUN npm run build

# Etapa 2: Servidor web para producción
FROM nginx:alpine

COPY --from=builder /app/dist/spa /usr/share/nginx/html
EXPOSE 80
