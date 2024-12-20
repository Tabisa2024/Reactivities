import {Container, Menu, Button} from 'semantic-ui-react';
import { useStore } from '../stores/store';



export default function NavBar() {
    const {activityStore} = useStore();
    return (
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item header>
                    <img src="/assests/logo.png" alt="logo" style={{marginRight: '10px'}}/>
                    Reactivites
                </Menu.Item>
                <Menu.Item name='Activites' />
                <Menu.Item>
                  <Button onClick={ () =>activityStore.openForm()} positive content='Create Activity'  />
                </Menu.Item>
            </Container>
        </Menu>
    )
}