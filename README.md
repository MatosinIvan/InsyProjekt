create(tm1: Tycoonmitglied {name:"DomiPromi",Robux:9600})
create(tm2: Tycoonmitglied {name:"DujePuje",Robux:0})
create(tm3: Tycoonmitglied {name:"Puje der Zweite",Robux:1})
create(tm4: Tycoonmitglied {name:"IvanPivan",Robux:682})
create(tm5: Tycoonmitglied {name:"noch ein Typ",Robux:0})

create(t1: Tycoon {name:"die professionellen",Erstellungsjahr:2017})
create(t2: Tycoon {name:"die Neulinge",Erstellungsjahr:2017})
create(t3: Tycoon {name:"die anderen Neulinge",Erstellungsjahr:2019})

create(s1: Sponsor {name:"Thanos"})
create(s2: Sponsor {name:"Manos"})
create(s3: Sponsor {name:"Panos"})

create (tm1)-[:LEITET {fuehrt_seit: 2017}]->(t1)
create (tm4)-[:MITGLIED_VON]->(t1)
create (tm2)-[:LEITET {fuehrt_seit: 2018}]->(t2)
create (tm3)-[:LEITET {fuehrt_seit: 2019}]->(t3)
create (tm5)-[:MITGLIED_VON]->(t3)

create (s1)-[:SPONSORED {monatliche_Robux: 1000}]->(t1)
create (s1)-[:SPONSORED {monatliche_Robux: 1200}]->(t2)
create (s2)-[:SPONSORED {monatliche_Robux: 1000}]->(t3)
create (s3)-[:SPONSORED {monatliche_Robux: 1000}]->(t3)
