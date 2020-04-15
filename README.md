# Athena desktop app MVP
The AI Coach

### Core purpose of Athena
The core purpose of Athena is to be an AI coach to help players improve their decision making regarding objectives and gameplay. Athena is a tool that **analyses your game in-progress** and provides you feedback as to what your options are and potential outcomes. 

Athena does not tell you what to do, nor does it make the execution any easier. Athena simply **brings to light what your options** are as well as provide advice on how to improve. 

---

### Features ( LEAGUE OF LEGENDS )

#### CSing
CS Overlay comparing current CS to average CS at higher tier (Bronze => Silver)

Provides insight as to what to do regarding CS. 
- Is your CS at an acceptable level and there's a gank possibility?
- Should you focus on CSing a bit longer?
- Zone the enemy?
- Grab some jungle mobs?
- Map awareness?

Toggle-able overlay 

#### Objective coach
The objective coach is an overlay that provies a handful of short tips based on how the game is going as well as a ordered list of objectives with winrate prediction percentages. 

Tips include:
- Who should I focus?
- Should I build differently? (Need more MR?)
- Need more cs? 
- Catch up in levels?
- Follow fed/tanky ally?
- Vision lacking? 

Only displays top two-three tips at a time maximum so as to not overwhelm the player.

These predictions are made by analysing other players games **in the same elo** and comparing the circumstances to your own. 

Circumstances: 
- Minion wave locations
- Current dragon status
- Team gold comparison
- Inhib status
- Tower status
- Both teams alive/dead status
- Baron

Current performance compared to other games. Breakdown by playstyle. 
Current performance compared to one tier higher (Bronze => Silver)

---

### Milestones

#### MVP for working base app ( BASE ) 
Base app milestones 

1. App that enables/disables Coach 
2. Enabling/Disabling coach allows overlays to be chosen 
3. Ability to hotkey on-off overlays 

#### MVP for working CS overlay ( LEAGUE OF LEGENDS )
CS overlay milestones

1. CS Overlay => Grabs current CS converts to CS/m
2. Compares your CS to enemy CS
3. Allows comparing to average CS at higher 
4. Provides tips/insight for CS and gold management. 

#### MVP for working coach app ( LEAGUE OF LEGENDS)
Coach overlay milestones

1. Provides objective winrate/priority analysis
2. Provides tips as to how the game is going 
3. Provides winrate prediction based on objectives 
4. Provides new winrate prediction achieved if certain objective is gotten
5. Predicts based on games of same elo 
6. Current performance breakdown 

At this point, MVP has been achieved. 

---

### Architectural overview

#### Frontend
The frontend C# app should **not** calculate any data, nor should it **directly** call the Riot API.

The frontend C# app connects to our own servers which then return the data we want to display. This makes the server API interchangable, allowing us to swap it for a different server that provides insight on other games with minimum change. 

#### Server
The server is a **Golang Gin** application that communicates with the desired API. The server acts as a middle-man between the API wrapper and the C# application. 

C# Application(message: Give me x data for y game) => Server(Call proper microservice) => Microservice(Consume and return proper data)

The server microservice is an API Gateway, it does not contain API data

#### API wrapper microservice
Contains all the data for the game and how we retrieve and consume that data.

Communicated with the API Gateway service

#### Terraform
Use Terraform to maintain and manage infrastructure 