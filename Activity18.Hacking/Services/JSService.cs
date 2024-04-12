using Activity18.Hacking.Services.Bases;

namespace Activity18.Hacking.Services;

public class JSService: BaseJSService
{
    private const string _methodInitMap = "initMap";
    public JSService(IJSRuntime jsRunTime) : base(jsRunTime)
    {
        
    }
    public async ValueTask InitMapAsync() => await this.ModuleInvokeVoidAsync(_methodInitMap);
    //public async ValueTask TestAsync() => await this.ModuleInvokeVoidAsync(_methodTest);
    //public async ValueTask AddClassAsync(ElementReference element, string nameClass) => await this.ModuleInvokeVoidAsync(JSSettings.HTMLElement.Method.addClass, element, nameClass);
    //public async ValueTask RemoveClassAsync(ElementReference element, string nameClass) => await this.ModuleInvokeVoidAsync(JSSettings.HTMLElement.Method.removeClass, element, nameClass);
    //public async ValueTask<RectangleDimension> GetWindowDimensionsAsync() => await this.ModuleInvokeAsync<RectangleDimension>(JSSettings.HTMLElement.Method.getWindowDimensions);
    //public async ValueTask<BoundingClientRect> GetBoundingClientRectAsync(ElementReference element) => await this.ModuleInvokeAsync<BoundingClientRect>(JSSettings.HTMLElement.Method.getRect, element);
    //public async ValueTask ScrollBottomAsync(ElementReference element) => await this.ModuleInvokeVoidAsync(JSSettings.HTMLElement.Method.scrollBottom, element);
}