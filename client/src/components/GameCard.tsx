import './GameCard.css'

interface GameCardProps {
    title: string;
    partNumber: number;
    imageName?: string;
}

export function GameCard({ title, partNumber, imageName }: GameCardProps) {
    const imagePath = imageName
        ? `/images/games/${imageName}`
        : `/images/placeholder.jpg`
    return (
        <div className="card">
            <img
                src={imagePath}
                alt={title}
                className="game-cover"
                onError={(e) => {
                    (e.target as HTMLImageElement).src = '/images/placeholder.jpg'
                }}
            />
            <h3>{title}</h3>
            <p>Часть {partNumber} в серии</p>
        </div>
    )
}