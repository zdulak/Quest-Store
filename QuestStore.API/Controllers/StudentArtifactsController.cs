﻿using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestStore.API.Dtos.Duplex;
using QuestStore.API.Dtos.OutDtos;
using QuestStore.Core.Entities;
using QuestStore.Core.Interfaces;

namespace QuestStore.API.Controllers
{
    public class StudentArtifactsController : LinkingGenericController<StudentArtifact, ArtifactDetailedDto, StudentArtifactBrief>
    {
        private readonly IStudentService _studentService;
        protected override bool ReverseKeyOrder { get; } = false;

        public StudentArtifactsController(IUnitOfWork unitOfWork, IMapper mapper, IStudentService studentService)
            : base(unitOfWork, mapper)
        {
            _studentService = studentService;
        }

        public override async Task<ActionResult<StudentArtifactBrief>> CreateResource(int id, int id2)
        {
            try
            {
                if (await _studentService.BuyArtifact(id, id2))
                {
                    return CreatedAtAction(
                        nameof(GetResource),
                        new {id, id2}, new StudentArtifactBrief {StudentId = id, ArtifactId = id2});
                }

                return StatusCode(StatusCodes.Status409Conflict, "Not enough coins.");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ErrorMessage);
            }
        }
    }
}