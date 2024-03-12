export type Team = {
  teamId: number;
  teamName: string;
  captainId: number;
  bowlers: [
    {
      bowlerId: number;
      bowlerLastName: string;
      bowlerFirstName: string;
      bowlerMiddleInit: string;
      bowlerAddress: string;
      bowlerCity: string;
      bowlerState: string;
      bowlerZip: string;
      bowlerPhoneNumber: string;
      teamId: number;
      team: string;
      bowlerScores: [
        {
          matchId: number;
          gameNumber: number;
          bowlerId: number;
          rawScore: number;
          handiCapScore: number;
          wonGame: boolean;
          bowler: string;
        },
      ];
      tourneyMatchEvenLaneTeams: [
        {
          matchId: number;
          tourneyId: number;
          lanes: string;
          oddLaneTeamId: number;
          evenLaneTeamId: number;
          evenLaneTeam: string;
          matchGames: [
            {
              matchId: number;
              gameNumber: number;
              winningTeamId: number;
              match: string;
            },
          ];
          oddLaneTeam: string;
          tourney: {
            tourneyId: number;
            tourneyDate: {
              year: number;
              month: number;
              day: number;
              dayOfWeek: number;
              dayOfYear: number;
              dayNumber: number;
            };
            tourneyLocation: string;
            tourneyMatches: [string];
          };
        },
      ];
      tourneyMatchOddLaneTeams: [
        {
          matchId: number;
          tourneyId: number;
          lanes: string;
          oddLaneTeamId: number;
          evenLaneTeamId: number;
          evenLaneTeam: string;
          matchGames: [
            {
              matchId: number;
              gameNumber: number;
              winningTeamId: number;
              match: string;
            },
          ];
          oddLaneTeam: string;
          tourney: {
            tourneyId: number;
            tourneyDate: {
              year: number;
              month: number;
              day: number;
              dayOfWeek: number;
              dayOfYear: number;
              dayNumber: number;
            };
            tourneyLocation: string;
            tourneyMatches: [string];
          };
        },
      ];
    },
  ];
};
