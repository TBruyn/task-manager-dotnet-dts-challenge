<script setup lang="ts">
import { onMounted, ref } from 'vue'
import { RouterLink } from 'vue-router'
import type { TaskMetadata } from '@/models/task'
import { getTaskMetadata } from '@/services/taskService'

const tasks = ref<TaskMetadata[]>([])
const isLoading = ref(false)
const errorMessage = ref<string | null>(null)

onMounted(async () => {
    isLoading.value = true

    try {
        tasks.value = await getTaskMetadata()
        console.log(tasks.value)
    } catch {
        errorMessage.value = 'Failed to load tasks'
    } finally {
        isLoading.value = false
    }
})
</script>
<template>
    <section class="task-sidebar">
        <header>
            <h1>Tasks</h1>
            <RouterLink to="/new">New</RouterLink>
        </header>

        <p v-if="isLoading">Loading tasks...</p>
        <p v-else-if="errorMessage">{{ errorMessage }}</p>

        <ul v-else class="task-list">
            <li v-for="task in tasks" :key="task.id">
                <RouterLink :to="`/${task.id}`">
                    <span>{{ task.title }}</span>
                    <small>{{ task.status }}</small>
                </RouterLink>
            </li>
        </ul>
    </section>

</template>
<style scoped>
.task-sidebar {
    padding: 1rem;
}

.sidebar-header {
    display: flex;
    align-items: center;
    justify-content: space-between;
}

.task-list {
    list-style: none;
    padding: 0;
}

.task-list a {
    display: flex;
    flex-direction: column;
    gap: 0.25rem;
    padding: 0.75rem 0;
    text-decoration: none;
}
</style>