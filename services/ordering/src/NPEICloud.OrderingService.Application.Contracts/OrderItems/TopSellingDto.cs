﻿using Volo.Abp.Application.Dtos;

namespace NPEICloud.OrderingService.OrderItems
{
    public class TopSellingDto : EntityDto
    {
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
        public int Units { get; set; }
    }
}
