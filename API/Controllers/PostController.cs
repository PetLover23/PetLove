﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Business.Services.UserServices;
using Data.Entities;
using Business.Services.PostServices;

namespace API.Controllers
{
    [Route("post/")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPostServices _post;

        public PostController(IPostServices post)
        {
            _post = post;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(Guid id)
        {
            Data.Models.ResultModel.ResultModel result = await _post.GetPostById(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet("trade/{id}")]
        public async Task<IActionResult> GetTradePost(Guid id)
        {
            Data.Models.ResultModel.ResultModel result = await _post.GetPostById(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}