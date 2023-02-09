Team firebirds = new Team("Firebirds");
Player john = new Player("John Henderson", 12);
Player tim = new Player ("Tim Nunn", 13);
firebirds.AddPlayer(john);
firebirds.AddPlayer(tim);


Team stupidbirds = new Team("Smallbirds");
Player joe = new Player("Joe Biden", 15);
Player don = new Player ("Don Trump", 16);
stupidbirds.AddPlayer(joe);
stupidbirds.AddPlayer(don);


Match match1 = new Match(firebirds, stupidbirds);
match1.DecideWin();

firebirds.DisplayRoster();
stupidbirds.DisplayRoster();