using System.Collections.Generic;

namespace EShopOnAbp.BasketService;

public class BasketDto
{
    public float TotalPrice { get; set; }
    public List<BasketItemDto> Items { get; set; }

    public BasketDto()
    {
        Items = new List<BasketItemDto>();
    }
}