﻿create table discount(
Id serial primary key,
UserId varchar(200) unique not null,
Rate smallint not null,
Code varchar(50) not null,
CreatedTime timestamp not null default CURRENT_TIMESTAMP
)