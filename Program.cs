// Web application that serves HTML Hello World
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configure the HTTP request pipeline
app.MapGet("/", () => Results.Content(@"
<!DOCTYPE html>
<html lang=""pt-BR"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Hello World</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            background-color: #f0f0f0;
        }
        .container {
            text-align: center;
            background: white;
            padding: 2rem;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }
        h1 {
            color: #333;
            font-size: 3rem;
            margin: 0;
        }
        p {
            color: #666;
            font-size: 1.2rem;
            margin-top: 1rem;
        }
        .change-bg-btn {
            background-color: #333;
            color: white;
            border: none;
            padding: 12px 24px;
            font-size: 1rem;
            border-radius: 5px;
            cursor: pointer;
            margin-top: 2rem;
            transition: all 0.3s ease;
            font-family: Arial, sans-serif;
        }
        .change-bg-btn:hover {
            background-color: #555;
            transform: translateY(-2px);
            box-shadow: 0 6px 12px rgba(0, 0, 0, 0.2);
        }
        .change-bg-btn:active {
            transform: translateY(0);
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.2);
        }
    </style>
</head>
<body>
    <div class=""container"">
        <h1>Hello, World!</h1>
        <p>Este é um exemplo de página HTML servida por uma aplicação C# web.</p>
        <button class=""change-bg-btn"" onclick=""changeBackgroundToBlack()"">Alterar para Background Preto</button>
    </div>
    <script>
        function changeBackgroundToBlack() {
            document.body.style.backgroundColor = 'black';
        }
    </script>
</body>
</html>", "text/html"));

app.Run();
