﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path,FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document,stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Rezervasyon PDF RAporu");
            document.Add(paragraph);
            document.Close();

            return File("pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");

        }

        public IActionResult StatickCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            

            PdfPTable pdfTable = new PdfPTable(3);
           
            pdfTable.AddCell("Misafir Adı");
            pdfTable.AddCell("Misafir Soyadı");
            pdfTable.AddCell("Misafir TC");

            pdfTable.AddCell("İbrahiim");
            pdfTable.AddCell("Demircik");
            pdfTable.AddCell("1111111111");

            pdfTable.AddCell("İbrahiim");
            pdfTable.AddCell("Demircik");
            pdfTable.AddCell("1111111111");

            pdfTable.AddCell("İbrahiim");
            pdfTable.AddCell("Demircik");
            pdfTable.AddCell("1111111111");

            document.Add(pdfTable);
            document.Close();

            return File("pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}
