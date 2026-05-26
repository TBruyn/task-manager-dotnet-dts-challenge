import { createRouter, createWebHistory } from 'vue-router'
import TaskView from '@/views/TaskView.vue'
import CreateTaskView from '@/views/CreateTaskView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/new',
      name: 'create',
      component: CreateTaskView,
    },
    {
      path: '/:id',
      name: 'task',
      component: TaskView,
    }
  ],
})

export default router
