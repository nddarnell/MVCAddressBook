﻿using Microsoft.AspNetCore.Http;
using MVCAddressBook.Services.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MVCAddressBook.Services
{
    public class BasicImageService : IImageService
    {
        public string ConvertByteArrayToFile(byte[] fileData, string extension)
        {
            if(fileData == null) return string.Empty;

            string imageBase64Data = Convert.ToBase64String(fileData);
            return $"data:{extension}; base64, {imageBase64Data}";
        }

        public async Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file)
        {
            using MemoryStream memoryStream = new();
            await file.CopyToAsync(memoryStream);
            byte[] byteFile = memoryStream.ToArray();

            return byteFile;
        }
    }
}
