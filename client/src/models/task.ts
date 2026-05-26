export enum TaskStatus {
  Todo = 'Todo',
  InProgress = 'InProgress',
  Done = 'Done',
}

export interface TaskMetadata {
  id: string
  title: string
  status: TaskStatus
  dueDate: string | null
}

export interface TaskItem extends TaskMetadata {
  createdAt: string
  description: string | null
}

export interface CreateTaskRequest {
  title: string
  description?: string | null
  status: TaskStatus
  dueDate?: string | null
}
