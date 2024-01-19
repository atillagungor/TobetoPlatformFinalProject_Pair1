﻿using Business.Abstracts;
using Business.Dtos.Requests.LiveContent;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiveContentsController : ControllerBase
    {
        ILiveContentService _liveContentService;

        public LiveContentsController(ILiveContentService liveContentService)
        {
            _liveContentService = liveContentService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLiveContentRequest createLiveContentRequest)
        {
            var result = await _liveContentService.AddAsync(createLiveContentRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _liveContentService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] GetLiveContentRequest getLiveContentRequest)
        {
            var result = await _liveContentService.GetByIdAsync(getLiveContentRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateLiveContentRequest updateLiveContentRequest)
        {
            var result = await _liveContentService.UpdateAsync(updateLiveContentRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteLiveContentRequest deleteLiveContentRequest)
        {
            var result = await _liveContentService.DeleteAsync(deleteLiveContentRequest);
            return Ok(result);
        }
    }
}