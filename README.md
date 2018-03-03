# ConcurrencyTest
An ASP.NET Web API to show currency problem while updating a single field in a record

I used 'West Wind WebSurge' to add load tests in concurent way to the project. 

Calling URL http://localhost:22190/api/cities/1 multiple times then checking Cities and CitiyLogs table shows the conflict. If WebSurge show 4000 calls to the above URL, field Number has been increased less numbers for example 3000 numbers.
