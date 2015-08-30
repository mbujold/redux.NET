﻿using Redux.TodoMvc.Universal.States;
using System;

namespace Redux.TodoMvc.Universal.Actions
{
    public class AddTodoAction : IAction
    {
        public string Text { get; set; }
    }

    public class DeleteTodoAction : IAction
    {
        public Guid TodoId { get; set; }
    }

    public class CompleteTodoAction : IAction
    {
        public Guid TodoId { get; set; }
    }

    public class CompleteAllTodosAction : IAction
    {
        public bool IsCompleted { get; set; }
    }

    public class ClearCompletedTodosAction : IAction
    {

    }

    public class FilterTodosAction : IAction
    {
        public TodosFilter Filter { get; set; }
    }
}
