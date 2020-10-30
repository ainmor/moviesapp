function my_function(message) {
    console.log("from utilities" + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript: " + result);
        });
}


function dotnetIncrementCountInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}