$Number = "%ErrorLevel%"
$Success = "D:\a\1\s\success.json"
$Failure = "D:\a\1\s\failure.json"
$Destination = "D:\a\1\s\application.json"
if($Number -eq 0){
Copy-Item $Success -Destination $Destination
}else{
Copy-Item $Failure -Destination $Destination
}
echo "$Number is cool"

