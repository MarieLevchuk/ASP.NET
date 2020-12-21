using Converter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Controllers
{
    public class ConverterController : ControllerBase
    {
        ITemperature _temperature = new Temperature();
        IValidator _validator = new TemperatureValidator();
        string  _filePath = Path.Combine(@"C:\Temp", "temperature.txt");
        string  _archivePath = Path.Combine(@"C:\Temp", "temperature.zip");

        [HttpGet]
        public IActionResult ConvertTemperture(int temperatureC)
        {
            if (_validator.ValueIsValid(temperatureC))
            {
                _temperature.CelsiusDegree = temperatureC;
                _temperature.ConvertCelsiusToFarenheit();
                return Ok();
            }
            else
                return Redirect("https://www.it-academy.by");
        }

        [HttpPost]
        public ActionResult SendTxtFile(int temperatureC)
        {
            CreateTxtFile(temperatureC);
                                   
            byte[] fileBytes = System.IO.File.ReadAllBytes(_filePath);
            string fileName = "temperature.txt";
            return File(fileBytes, MediaTypeNames.Text.Plain, fileName);
        }

        [HttpPost]
        public IActionResult SendZipArchive()
        {
            CreateArchive();
            byte[] bytes = System.IO.File.ReadAllBytes(_archivePath);
            string fileName = "temperature.zip";
            return File(bytes, MediaTypeNames.Application.Zip, fileName);
        }

        [HttpPost]
        public IActionResult SendStreamOfBytes()
        {
            FileStream fstream = new FileStream(_filePath, FileMode.Open);
            string fileName = "temperature.txt";
            return File(fstream, MediaTypeNames.Text.Plain, fileName);
        }

        public void CreateTxtFile(int temperatureC)
        {            
            string writePath = @"c:\Temp\temperature.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, Encoding.Default))
                {
                    sw.WriteLine($"Temperture in celsius is {temperatureC}");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }              

        public void CreateArchive()
        {
            try
            {
                using (FileStream zipToOpen = new FileStream(_archivePath, FileMode.OpenOrCreate))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        ZipArchiveEntry readmeEntry = archive.CreateEntryFromFile(_filePath, "temperature.txt");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }            
        }              

        public IActionResult IsValid()
        {
            if (_validator.ValueIsValid(_temperature.CelsiusDegree))
            {
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}
