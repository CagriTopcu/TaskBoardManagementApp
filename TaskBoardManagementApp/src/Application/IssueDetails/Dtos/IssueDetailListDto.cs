﻿namespace TaskBoardManagementApp.Application.IssueDetails.Dtos;

public record IssueDetailListDto
{
    public Guid Id { get; set; }
    public Guid IssueId { get;  set; }
    public string Description { get;  set; }
    public string Comments { get; set; }
}