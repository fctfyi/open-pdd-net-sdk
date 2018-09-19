using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class SearchDdkThemeGoodsResponseModel : PddResponseModel
    {
        /// <summary>
/// 主题列表返回对象
/// </summary>
[JsonProperty("theme_list_get_response")]
public List<ThemeListGetResponseResponseModel> ThemeListGetResponse {get;set;}

    public partial class ThemeListGetResponseResponseModel : PddResponseModel
    {
        
}

}
}
