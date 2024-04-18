function Callc() {
    DotNet.involkeMethodAsync("BlazorServerDemo", "Callcsharp").then(res => {
        alert('return da c# func: ' + res);
    });
}