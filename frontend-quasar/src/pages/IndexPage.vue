<template>
  <q-page class="q-pa-md">
    <q-form @submit.prevent="registrarUsuario" class="q-gutter-md">
      <q-input
        filled
        v-model="usuario.nombre"
        label="Nombre"
        :rules="[val => !!val || 'El nombre es requerido']"
      />
      <q-input
        filled
        v-model="usuario.email"
        label="Correo Electrónico"
        type="email"
        :rules="[val => /.+@.+\..+/.test(val) || 'Correo inválido']"
      />
      <q-select
        filled
        v-model="usuario.rol"
        :options="roles"
        label="Rol"
        :rules="[val => !!val || 'El rol es requerido']"
      />
      <q-btn type="submit" label="Registrar" color="primary" />
    </q-form>
  </q-page>
</template>

<script setup>
import { ref } from 'vue'

const usuario = ref({
  nombre: '',
  email: '',
  rol: ''
})

const roles = ['Administrador', 'Usuario', 'Invitado']

const registrarUsuario = async () => {
  try {
    const response = await fetch('http://localhost:5000/api/usuarios', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(usuario.value)
    })

    if (!response.ok) throw new Error('Error al registrar')

    alert('Usuario registrado correctamente')
    usuario.value = { nombre: '', email: '', rol: '' }
  } catch {
    alert('Ocurrió un error al enviar los datos')
  }
}
</script>
