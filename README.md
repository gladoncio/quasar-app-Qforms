# Registro de Usuarios - Proyecto Fullstack

Este proyecto es una aplicación web simple para registrar usuarios. Utiliza una API en .NET y un frontend desarrollado con Quasar Framework. Los datos se almacenan en una base de datos MySQL. Se incluye Adminer para la administración visual de la base de datos.

---

## 🚀 Requisitos

- Docker y Docker Compose instalados
- Node.js y pnpm instalados (para el frontend)
- Acceso a Adminer para crear la base de datos manualmente

---

## 🛠️ Instalación

### 1. Clonar el repositorio

```
git clone https://github.com/usuario/proyecto-registro.git
cd proyecto-registro
```

### 2. Crear archivo `.env`

Copia el archivo `.env.example` y renómbralo a `.env`. Luego ajusta los valores si es necesario:

```
cp .env.example .env
```

Contenido sugerido:
 
```
MYSQL_ROOT_PASSWORD=root
MYSQL_DATABASE=registrodb
MYSQL_USER=registro
MYSQL_PASSWORD=registropass
ADMINER_PORT=8081
```



---

### 3. Iniciar los servicios

Ejecuta el siguiente comando para levantar los contenedores:

```
docker-compose up --build
```

Esto creará los contenedores de:
- MySQL
- Adminer
- API en .NET

---

### 4. Crear la base de datos manualmente

Accede a Adminer en tu navegador:
```
http://localhost:8070/
```


Conéctate con los datos que configuraste en `.env`, por ejemplo:

- **Servidor**: `mysql`
- **Usuario**: `registro`
- **Contraseña**: `registropass`
- **Base de datos**: `registrodb`

Una vez dentro, ejecuta esta consulta SQL para crear la tabla:

```sql
CREATE TABLE Usuarios (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Nombre VARCHAR(100) NOT NULL,
  Email VARCHAR(100) NOT NULL,
  Rol VARCHAR(50) NOT NULL
);
```

---

### 5. Iniciar el frontend

Navega a la carpeta del frontend y ejecuta:

```
cd frontend-quasar
pnpm install
pnpm run dev
```

La aplicación estará disponible en:

```
http://localhost:9001/
```


---

## 🧪 Pruebas

- Verifica que al registrar un usuario, los datos se almacenen correctamente en la base de datos.
- Puedes usar Adminer para revisar los registros creados.

---

## 🧼 Detener los servicios

Para detener todo:

```
docker-compose down
```

---

## 📝 Notas

Este proyecto no implementa migraciones automáticas, por lo tanto **debes crear la base de datos y la tabla manualmente** en Adminer antes de registrar usuarios.

---
