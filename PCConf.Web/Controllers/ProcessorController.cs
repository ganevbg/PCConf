﻿namespace PCConf.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PCConf.Domain.Services;
    using PCConf.Models.Parts;
    using System;
    using System.Threading.Tasks;

    public class ProcessorController : Controller
    {
        private readonly IProcessorService _processorService;

        public ProcessorController(IProcessorService processorService)
        {
            _processorService = processorService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _processorService.Search();

            return View(list);
        }

        public async Task<IActionResult> Info(Guid id)
        {
            var item = await _processorService.Get(id);

            return View(item);
        }

        public async Task<IActionResult> Upsert(Guid? id)
        {
            var item = new Processor();
            if (id.HasValue)
            {
                item = await _processorService.Get(id.Value);
            }

            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Upsert(Processor item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }

            await _processorService.Upsert(item);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete( Guid id)
        {
            _processorService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
