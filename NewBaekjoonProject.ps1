param (
    [string]$ProblemNumber,
    [string]$ProblemTitle
)

# 네임스페이스용 이름은 dot(.) 대신 underscore(_) 사용
$namespaceName = "Baekjoon._${ProblemNumber}_${ProblemTitle}"
$projectName = "Baekjoon.$ProblemNumber" + "_$ProblemTitle"
$projectDir = Join-Path "." $projectName
$solverClassName = "${ProblemTitle}Solver"
$commonProjectPath = ".\Baekjoon.Common\Baekjoon.Common.csproj"
$utf8Bom = New-Object System.Text.UTF8Encoding($true)

# 1. 콘솔 프로젝트 생성
dotnet new console -n $projectName

# 2. Solver.cs 템플릿 (한글 제거)
$solverCode = @"
using System;
using Baekjoon.Common;

namespace $namespaceName
{
    public class $solverClassName
    {
        public void Run()
        {
            Console.WriteLine(""); // 문제 출력 직접 작성
            // 여기에 풀이 작성
        }
    }
}
"@

# 3. Program.cs 템플릿
$programCode = @"
using System;

namespace $namespaceName
{
    class Program
    {
        static void Main(string[] args)
        {
            var solver = new $solverClassName();
            solver.Run();
        }
    }
}
"@

# 4. 저장 경로 설정
$solverPath = Join-Path $projectDir "$solverClassName.cs"
$programPath = Join-Path $projectDir "Program.cs"

# 5. UTF-8 BOM으로 파일 저장
[System.IO.File]::WriteAllLines($solverPath, $solverCode, $utf8Bom)
[System.IO.File]::WriteAllLines($programPath, $programCode, $utf8Bom)

# 6. 공통 프로젝트 참조
if (Test-Path $commonProjectPath) {
    dotnet add "$projectDir\$projectName.csproj" reference $commonProjectPath
    Write-Host "✅ Baekjoon.Common 참조 추가 완료!"
} else {
    Write-Host "⚠️ Baekjoon.Common.csproj가 없습니다. 참조 생략됨."
}

# 7. 솔루션에 등록
dotnet sln add "$projectDir\$projectName.csproj"
Write-Host "🎉 '$projectName' 프로젝트 생성 완료!"
