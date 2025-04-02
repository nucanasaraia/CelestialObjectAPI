using AutoMapper;
using CelestialObject.Data;
using CelestialObject.DTOs;
using CelestialObject.Models;
using CelestialObject.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CelestialObject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CelestialObjectsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public CelestialObjectsController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("add-celestial-objects")]
        public ActionResult AddObjects(AddObjects requests)
        {
            var objects = _mapper.Map<CelestialObjects>(requests);
            _context.CelestialObjects.Add(objects);
            _context.SaveChanges();

            return Ok(objects);
        }

        [HttpGet("get-all")]
        public ActionResult GetAll()
        {
            var objects = _context.CelestialObjects.ToList();
            return Ok(objects);
        }

        [HttpGet("get-main")]
        public ActionResult GetMain()
        {
            var objects = _context.CelestialObjects.ToList();
            var returnInfo = _mapper.Map<List<MainInfoDTO>>(objects);
            return Ok(returnInfo);
        }

        [HttpGet("get-by-id")]
        public ActionResult GetID(int id)
        {
            var info = _context.CelestialObjects.FirstOrDefault(x => x.Id == id);
            var retirnInfo = _mapper.Map<SpecificInfoDTO>(info);

            return Ok(retirnInfo);
        }

        [HttpGet("get-science-info")]
        public ActionResult GetScience()
        {
            var objects = _context.CelestialObjects.ToList();
            var returnInfo = _mapper.Map<List<ScienceInfoDTO>>(objects);

            return Ok(returnInfo);
        }

        [HttpGet("get-location")]
        public ActionResult GetLocation()
        {
            var location = _context.CelestialObjects.ToList();
            var retunrInfo = _mapper.Map<List<LocationDTO>>(location);

            return Ok(retunrInfo);
        }

        [HttpGet("get-by-type/{type}")]
        public ActionResult GetByType(string type)
        {
            var info = _context.CelestialObjects.Where(a => a.Type == type).ToList();
            if (info != null)
            {
                var returnInfo = _mapper.Map<List<MainInfoDTO>>(info);
                return Ok(returnInfo);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("get-interesting-ones")]
        public ActionResult GetInteresting()
        {
            var interesting = _context.CelestialObjects
                .Where(a => a.InterestingFacts != null) 
                .ToList();

            var returnInfo = _mapper.Map<List<MainInfoDTO>>(interesting);
            return Ok(returnInfo);
        }



        [HttpGet("Search/{term}")]
        public ActionResult Search(string term)
        {
           
            var results = _context.CelestialObjects
                .Where(a => a.Name.Contains(term) ||
                            a.AlternateDesignation.Contains(term) ||
                            a.Constellation.Contains(term) ||
                            a.Type.Contains(term))
                .ToList();

            if (results.Any())  
            {
                var returnInfo = _mapper.Map<List<MainInfoDTO>>(results);
                return Ok(returnInfo);
            }
            else
            {
                return NotFound("No celestial objects found matching the search term.");
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCelestialObject(int id, AddObjects request)
        {
            var celestialObject = _context.CelestialObjects.FirstOrDefault(c => c.Id == id);

            if (celestialObject == null)
            {
                return NotFound($"Celestial object with ID {id} not found.");
            }

            _mapper.Map(request, celestialObject);

            _context.SaveChanges();

            var returnInfo = _mapper.Map<MainInfoDTO>(celestialObject);
            return Ok(returnInfo);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCelestialObject(int id)
        {
            var celestialObject = _context.CelestialObjects.FirstOrDefault(c => c.Id == id);

            if (celestialObject == null)
            {
                return NotFound($"Celestial object with ID {id} not found.");
            }

            _context.CelestialObjects.Remove(celestialObject);

            _context.SaveChanges();
            return Ok($"Celestial object with ID {id} has been deleted.");
        }


    }
}
