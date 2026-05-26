<script setup lang="ts">
import TaskSidebar from './components/TaskSidebar.vue'
import { RouterView } from 'vue-router'
</script>

<template>
  <div class="layout">
    <aside class="sidebar">
      <TaskSidebar />
    </aside>
    <main class="content">
      <RouterView />
    </main>
  </div>
</template>

<style scoped>
.layout {
  display: flex;
  height: 100vh;
}

.sidebar {
  width: 320px;
  border-right: 1px solid #ddd;
}

.content {
  flex: 1;
  padding: 1rem;
}
</style>
