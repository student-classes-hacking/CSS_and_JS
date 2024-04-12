
namespace Activity18.Hacking.Services.Bases;
/// <summary>
/// Interop Field service  using JS isolation available on NET 5.0
/// </summary>
public abstract class BaseJSService
{
    protected readonly IJSRuntime _jsRunTime;
    protected IJSObjectReference? _module;

    protected Settings _settings;

    private const int TIME_IN_SECONDS_FOR_CANCELATION_TOKEN = 4;

    public BaseJSService(IJSRuntime jsRunTime, Settings? settings = null)
    {
        _jsRunTime = jsRunTime;
        _settings = settings is null ?  new Settings() : settings;
    }

    public class Settings
    {
        private string _fileName;
        private string _moduleName;
        private string _path;
        public string FILE_NAME => _fileName;
        public string MODULE_NAME => _moduleName;
        public string PATH => _path;
        public Settings()
        {
            _fileName = "file.js";
            _moduleName = "module";
            _path = "./js/modules";
        }
    }

    protected string GetPath() => _settings.PATH;
    protected string GetCompletedNameFile() => _settings.FILE_NAME;
    protected string GetModuleName() => _settings.MODULE_NAME;
    protected virtual double GetTimeForCancellationTokenSource() => TIME_IN_SECONDS_FOR_CANCELATION_TOKEN;

    protected string JSMethod(string nameMethod) => $"{this.GetModuleName()}.{nameMethod}";
    protected CancellationToken GetCancelationToken => (new CancellationTokenSource(TimeSpan.FromSeconds(GetTimeForCancellationTokenSource()))).Token;
    protected async ValueTask ImportModuleAsync()
    {
        try
        {
            _module ??= await _jsRunTime.InvokeAsync<IJSObjectReference>("import", this.GetCancelationToken, $"{this.GetPath()}/{this.GetCompletedNameFile()}");
        }
        catch (Exception ex)
        {
            throw new Exception($"Error en la importación de los ficheros correspondientes al diagrama: {ex.Message}");
        }
    }
    protected async ValueTask ModuleInvokeVoidAsync(string jsMethod, params object[] parameters)
    {
        try
        {
            if (_module is null)
            {
                await this.ImportModuleAsync();
            }
            if (parameters is null || !parameters.Any())
            {
                await _module!.InvokeVoidAsync(JSMethod(jsMethod), GetCancelationToken);
            }
            else
            {
                await _module!.InvokeVoidAsync(JSMethod(jsMethod), GetCancelationToken, parameters);
            }
        }
        catch (Exception ex)
        {
            ManageExceptions(new Exception($"{ex.Message}. Error method: {jsMethod}"));
        }
    }
    protected async ValueTask<TResult> ModuleInvokeAsync<TResult>(string jsMethod, params object[] parameters)
    {
        var result = default(TResult);
        try
        {
            if (_module is null)
            {
                await this.ImportModuleAsync();
            }
            if (parameters is null || !parameters.Any())
            {
                result = await _module!.InvokeAsync<TResult>(JSMethod(jsMethod), GetCancelationToken);
            }
            else
            {
                result = await _module!.InvokeAsync<TResult>(JSMethod(jsMethod), GetCancelationToken, parameters);
            }
        }
        catch (Exception ex)
        {
            ManageExceptions(new Exception($"{ex.Message}. Error method: {jsMethod}"));
        }
        return result;
    }
    protected async ValueTask<TResult[]> ModuleInvokeParamsAsync<TResult>(string jsMethod, params object[] parameters)
    {
        var result = default(TResult[]);
        try
        {
            if (_module is null)
            {
                await this.ImportModuleAsync();
            }
            if (parameters is null || !parameters.Any())
            {
                result = await _module!.InvokeAsync<TResult[]>(JSMethod(jsMethod), GetCancelationToken);
            }
            else
            {
                result = await _module!.InvokeAsync<TResult[]>(JSMethod(jsMethod), GetCancelationToken, parameters);
            }
        }
        catch (Exception ex)
        {
            ManageExceptions(new Exception($"{ex.Message}. Error method: {jsMethod}"));
        }
        return result;
    }
    //protected async ValueTask<TResult> InvokeExistingMethodAsync<TResult>(string jsMethod, params object[] parameters)
    //{
    //    var result = default(TResult);
    //    try
    //    {
    //        if (parameters is null || !parameters.Any())
    //        {
    //            result = await _jsRunTime!.InvokeAsync<TResult>(jsMethod);
    //        }
    //        else
    //        {
    //            result = await _jsRunTime!.InvokeAsync<TResult>(jsMethod, parameters);
    //        }
    //    }
    //    catch (Exception)
    //    {
    //        Console.Error.WriteLine($"Error js method: {jsMethod}");
    //        throw;
    //    }
    //    return result;
    //}

    public void ManageExceptions(Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        throw ex;
    }
    public ValueTask DisposeAsync()
    {
        if (_module != null)
        {
            return _module.DisposeAsync();
        }
        return new ValueTask(Task.CompletedTask);
    }
}