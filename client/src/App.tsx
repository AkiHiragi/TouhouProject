import React, { useEffect, useState } from 'react';
import './App.css';

interface Game {
  id: number;
  title: string;
  releaseOrder: number;
  coverImageUrl: string;
}

function App() {
  const [games, setGames] = useState<Game[]>([]);

  useEffect(() => {
    fetch('/api/games')
      .then((response => response.json()))
      .then(data => setGames(data))
      .catch(error => console.error('Error', error));
  }, [])

  return (
    <div>
      <h1>Touhou Games</h1>
      {games.length == 0 ?
        <p>Loading...</p> :
        <ul>
          {games.map(game => (
            <li key={game.id}>
              <h2>{game.title}</h2>
              <p>Номер в серии: {game.releaseOrder}</p>
            </li>
          ))}
        </ul>
      }
    </div>
  );
}

export default App;
