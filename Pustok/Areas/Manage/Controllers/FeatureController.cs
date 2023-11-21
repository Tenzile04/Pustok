//using Pustok.DAL;
//using Pustok.Models;
//using Microsoft.AspNetCore.Mvc;


//namespace Pustok.Areas.Manage.Controllers
//{
//    [Area("Manage")]
//    public class featureController : Controller
//    {
//        private readonly AppDbContext _context;
//        public FeatureController(AppDbContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Index()
//        {
//            List<Feature> features = _context.Features.ToList();

//            return View(features);
//        }
//        public IActionResult Create()
//        {
//            return View();
//        }
//        [HttpPost]
//        public IActionResult Create(Feature feature)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View();
//            }

//            _context.Features.Add(service);
//            _context.SaveChanges();

//            return RedirectToAction("index");
//        }
//        public IActionResult Update(int id)
//        {
//            Feature wantedFeature = _context.Features.FirstOrDefault(f => f.Id == id);

//            if (wantedFeature == null) return NotFound();

//            return View(wantedFeature);
//        }

//        [HttpPost]
//        public IActionResult Update(Feature feature)
//        {
//            if (!ModelState.IsValid) return View();

//            Feature existFeature = _context.Features.FirstOrDefault(x => x.Id == feature.Id);

//            if (existFeature == null) return NotFound();

//            existFeature.Title1 = feature.Title1;
//            existFeature.Title2 = feature.Title2;
//            existFeature.Icon = feature.Icon;

//            _context.SaveChanges();

//            return RedirectToAction("index");
//        }

//        public IActionResult Delete(int id)
//        {
//            Feature wantedFeature = _context.Features.FirstOrDefault(f => f.Id == id);

//            if (wantedFeature == null) return NotFound();

//            return View(wantedFeature);
//        }

//        [HttpPost]
//        public IActionResult Delete(Feature feature)
//        {
//            var existFeature = _context.Features.FirstOrDefault(x => x.Id == feature.Id);

//            if (existFeature == null)
//            {
//                return NotFound();
//            }

//            _context.Features.Remove(existFeature);
//            _context.SaveChanges();

//            return RedirectToAction("Index");
//        }
//    }
//}