﻿using Microsoft.AspNetCore.Mvc;
using VVCyberAware.Data;
using VVCyberAware.Database.Repositories;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly GenericRepository<SubCategoryModel> _subCRepo;

        public SubCategoryController(ApplicationDbContext context, GenericRepository<SubCategoryModel> subCRepo)
        {
            _context = context;
            _subCRepo = subCRepo;
        }




        [HttpGet("SubCategories")]
        public ActionResult<List<SubCategoryModel>> GetSubCategories()
        {
            var subCategories = _subCRepo.GetAll();

            if (subCategories != null)
            {
                return Ok(subCategories);
            }

            return BadRequest();
        }




        [HttpGet("SubCategory/{id}")]
        public ActionResult<SubCategoryModel> GetSingleSubCategory(int id)
        {
            var subCategory = _subCRepo.GetModelById(id);

            if (subCategory == null)
            {
                return NotFound();
            }

            return Ok(subCategory);

        }


        [HttpPost("SubCategory")]
        public async Task<ActionResult> PostSubCategory(SubCategoryModel newSubCategory)
        {
            if (newSubCategory == null)
            {
                return BadRequest();
            }


            await _subCRepo.Add(newSubCategory);

            _context.SaveChanges();

            return Ok(newSubCategory);
        }




        [HttpDelete("SubCategory/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var subCategory = _subCRepo.GetModelById(id);

            if (subCategory == null)
            {
                return NotFound();
            }


            await _subCRepo.Delete(subCategory.Id);

            _context.SaveChanges();

            return Ok(subCategory);
        }


    }
}
