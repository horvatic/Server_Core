﻿using System;

namespace Server.Core
{
    public class HttpResponse : IHttpResponse
    {
        public HttpResponse()
        {
        }

        public HttpResponse(IHttpResponse copy)
        {
            HttpStatusCode = copy.HttpStatusCode;

            CacheControl = copy.CacheControl;

            ContentType = copy.ContentType;

            ContentDisposition = copy.ContentDisposition;

            Filename = copy.Filename;

            FilePath = copy.FilePath;

            Body = copy.Body;
        }

        public string HttpStatusCode { get; set; } = "200 OK";
        public string CacheControl { get; set; } = "no-cache";
        public string ContentType { get; set; } = "text/html";
        public string ContentDisposition { get; set; }
        public string Filename { get; set; }
        public string FilePath { get; set; }
        public string Body { get; set; } = "";

        public IHttpResponse Clone()
        {
            return new HttpResponse(this);
        }
    }
}