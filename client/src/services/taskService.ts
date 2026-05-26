import type { CreateTaskRequest, TaskItem, TaskMetadata } from '@/models/task'

const API_BASE_URL = 'http://localhost:5057'

export async function getTaskMetadata(): Promise<TaskMetadata[]> {
  const response = await fetch(`${API_BASE_URL}/tasks`)

  if (!response.ok) {
    throw new Error('Failed to fetch task metadata')
  }

  return response.json()
}

export async function getTaskById(id: string): Promise<TaskItem> {
  const response = await fetch(`${API_BASE_URL}/tasks/${id}`)

  if (!response.ok) {
    throw new Error(`Failed to fetch task with id ${id}`)
  }

  return response.json()
}

export async function postTask(createTaskRequest: CreateTaskRequest): Promise<TaskItem> {
  const response = await fetch(`${API_BASE_URL}/tasks`, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(createTaskRequest),
  })

  if (!response.ok) {
    throw new Error('Failed to post task')
  }

  return response.json()
}
