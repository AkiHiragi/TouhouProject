import { useEffect, useState } from 'react';
import './App.css';
import { GameCard } from './GameCard';

interface Game {
  id: number;
  title: string;
  releaseOrder: number;
  coverUrl?: string;
}

function App() {
  const [games, setGames] = useState<Game[]>([]);

  useEffect(() => {
    fetch('/api/games')
      .then(response => response.json())
      .then(data => setGames(data));
  }, [])

  return (
    <div className="app">
      <h1>Touhou Project</h1>
      {games.length === 0 ? (
        <p>Загрузка...</p>
      ) : (
        <div className="game-list">
          {games.map(game => (
            <GameCard
              key={game.id}
              title={game.title}
              partNumber={game.releaseOrder}
            />
          ))}
        </div>
      )}
    </div>
  );
}


export default App;
