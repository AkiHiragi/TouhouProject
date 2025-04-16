interface GameCardProps {
    title: string;
    partNumber: number;
}

export function GameCard({ title, partNumber }: GameCardProps) {
    return (
        <div className="card">
            <h3>{title}</h3>
            <p>Часть {partNumber} в серии</p>
        </div>
    )
}