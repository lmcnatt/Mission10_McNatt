import { useEffect, useState } from 'react';
import { Team } from '../types/Team';

function TeamList() {
  const [teamData, setTeamData] = useState<Team[]>([]);

  useEffect(() => {
    const fetchTeamData = async () => {
      const rsp = await fetch('http://localhost:5033/Bowling/Teams');
      const f = await rsp.json();
      setTeamData(f);
    };
    fetchTeamData();
  }, []);

  return (
    <div className="container">
      <div className="row">
        <h4 className="text-center display-3">Team Captains</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Team Name</th>
            <th>Captain Name</th>
            <th>Captain Average Score</th>
          </tr>
        </thead>
        <tbody>
          {teamData.map((f) => (
            <tr key={f.teamId}>
              <td>{f.teamName}</td>
              <td>
                {
                  f.bowlers?.find((b) => b.bowlerId === f.captainId)
                    ?.bowlerFirstName
                }{' '}
                {
                  f.bowlers?.find((b) => b.bowlerId === f.captainId)
                    ?.bowlerMiddleInit
                }{' '}
                {
                  f.bowlers?.find((b) => b.bowlerId === f.captainId)
                    ?.bowlerLastName
                }
              </td>
              <td>
                {(() => {
                  const captain = f.bowlers?.find(
                    (b) => b.bowlerId === f.captainId,
                  );
                  if (captain && captain.bowlerScores) {
                    const sumOfScores = captain.bowlerScores.reduce(
                      (sum, score) => sum + score.rawScore,
                      0,
                    );
                    const countOfScores = captain.bowlerScores.length;
                    return countOfScores > 0
                      ? Math.round(sumOfScores / countOfScores)
                      : '';
                  }
                })()}
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default TeamList;
