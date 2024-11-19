import { Button, Card, CardContent, CardDescription, CardHeader, CardMeta, Image } from "semantic-ui-react";
import { Activity } from "../../app/models/activity";

interface Props{
    activity: Activity
    cancelSelectActivity: () => void;
    openForm: (id: string) => void;
}

export default function ActivityDeatils({activity, cancelSelectActivity}: Props) {
    return(
        <Card fluid>
        <Image src={'/assets/categoryImages/${activity.category}.jpg'} />
        <CardContent>
          <CardHeader>{activity.title}</CardHeader>
          <CardMeta>
            <span>{activity.date}</span>
          </CardMeta>
          <CardDescription>
            {activity.description}
       
          </CardDescription>
        </CardContent>
        <Card.Content extra>
          <Button.Group widths='2'>
            <Button onClick={() => (activity.id)}basic color='blue' contnet='Edit' />
            <Button onClick={cancelSelectActivity} basic color='grey' content='Cancel' />
          </Button.Group>
        </Card.Content>
      </Card>
    )
}