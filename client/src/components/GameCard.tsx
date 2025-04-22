import { Badge, Button, Card } from 'react-bootstrap';
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
        <Card style={{ width: '18rem', margin: '10px' }}>
            {imageName && (
                <Card.Img
                    variant='top'
                    src={imagePath}
                    alt={title}
                    style={{ height: '350px', objectFit: 'cover' }}
                />
            )}
            <Card.Body>
                <Card.Title>{title}</Card.Title>
                <Card.Text>
                    <Badge bg='danger'>Часть {partNumber}</Badge>
                </Card.Text>
                <Button variant='primary'>Подробнее</Button>
            </Card.Body>
        </Card>
    )
}