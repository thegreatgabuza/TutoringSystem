using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutoringSystem.Data;
using TutoringSystem.Models;

public class ApplyController : Controller
{
    private readonly ApplicationDbContext _context;

    public ApplyController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Apply([FromForm] Tutor tutor)
    {
        if (tutor.FileUpload == null)
        {
            ModelState.AddModelError("FileUpload", "Please upload a file.");
            return View(tutor);
        }

        var fileExtension = Path.GetExtension(tutor.FileUpload.FileName);

        if (!fileExtension.Equals(".pdf") && !fileExtension.Equals(".doc") && !fileExtension.Equals(".docx"))
        {
            ModelState.AddModelError("FileUpload", "Only PDF, DOC, and DOCX files are allowed.");
            return View(tutor);
        }

        // Save the file.
        // ...

        if (!ModelState.IsValid)
        {
            return View(tutor);
        }

        _context.Tutors.Add(tutor);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }
}
